namespace VitalHealth.Shared
{
    public static class PatientRecordContext
    {
        public static int SelectedQueueId { get; set; }
        public static int SelectedPatientId { get; set; }
        public static int SelectedRecordId { get; set; }

        public static void Clear()
        {
            SelectedQueueId = 0;
            SelectedPatientId = 0;
            SelectedRecordId = 0;
        }
    }
}