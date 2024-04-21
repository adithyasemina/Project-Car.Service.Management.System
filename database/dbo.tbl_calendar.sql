CREATE TABLE [dbo].[tbl_calendar] (
    [refId]   INT           NOT NULL,
    [vehicle] NVARCHAR (50) NOT NULL,
    [date]    NVARCHAR (50) NOT NULL,
    [time]    NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([refId] ASC)
);

