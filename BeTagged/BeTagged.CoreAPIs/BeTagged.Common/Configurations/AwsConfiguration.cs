namespace BeTagged.Common.Configurations;

public class AwsConfiguration
{
    public const string Section = "AwsConfig";

    public string AccessKeyId { get; set; }

    public string AccessKeySecret { get; set; }

    public string S3BucketName { get; set; }

    public Uri S3CloudFrontDomain { get; set; }

    public string S3CloudFrontUrlSignerKeyPairId { get; set; }

    public string S3CloudFrontUrlSignerPrivateKey { get; set; }
}
