﻿using Mindstorms.Core.EV3;

namespace Mindstorms.Core.Resources;

public class ResourceUploader
{
    public const string Application = "Application";
    public const string Resources = "Resources";
    public const string Sounds = "Sounds";
    public const string Images = "Images";
    public const string BaseDirectory = "/home/root/lms2012/prjs";

    public static string UploadApplication(Brick brick, string fileame)
    {
        return Upload(brick, fileame, Application, BaseDirectory);
    }

    public static string UploadImage(Brick brick, string filename)
    {
        var destinationFolder = $"{BaseDirectory}/{Images}";
        return Upload(brick, filename, Images, destinationFolder);
    }

    public static string UploadSound(Brick brick, string filename)
    {
        var destinationFolder = $"{BaseDirectory}/{Sounds}";
        return Upload(brick, filename, Sounds, destinationFolder);
    }

    private static string Upload(Brick brick, string filename, string subDirectory, string destinationFolder)
    {
        var destination = $"{destinationFolder}/{filename}";
        var lastSlashIndex = destinationFolder.LastIndexOf('/');
        var parent = destinationFolder[..lastSlashIndex];
        var destinationFolderName = destinationFolder[(lastSlashIndex + 1)..] + '/';
        if (parent != null)
        {
            if (!brick.IsExists($"{parent}/{destinationFolderName}") || !brick.IsExists(destination))
            {
                UploadFile(brick, filename, subDirectory, destination);
            }
        }

        return destination;
    }

    private static void UploadFile(Brick brick, string filename, string subDirectory, string destination)
    {
        var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Resources, subDirectory, filename);
        brick.CopyFileToBrick(path, destination);
    }
}
