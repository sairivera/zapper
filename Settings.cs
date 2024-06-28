namespace Zapper.Enumerations
{
    /// <summary>
    /// Enumerates the settings available for the user.
    /// </summary>
    public enum Settings : short
    {
        // SMS Notifications enabled
        SMSNotifications = 1,

        // Push Notifications enabled
        PushNotifications,

        // Bio-metrics enabled
        BioMetrics,

        // Camera enabled
        Camera,

        // Location enabled
        Location,

        // NFC enabled
        NFC,

        // Vouchers enabled
        Vouchers,

        // Loyalty enabled
        Loyalty
    }
}
