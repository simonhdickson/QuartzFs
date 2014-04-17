namespace QuartzFs
open System

module Time =
    let roundMinute (date:DateTimeOffset) =
        let d = date.AddMinutes 1.0
        DateTimeOffset(d.Year, d.Month, d.Day, d.Hour, d.Minute, 0, d.Offset)
        
module Job =
    ()

module Cron =
    type Cron = { name:string }
    type Seconds = Seconds of string
    type Minutes = Minutes of string
    type Hours = Hours of string
    type DayOfMonth = DayOfMonth of string
    type Month = Month of string
    type DayOfWeek = DayOfWeek of string
    type Years = Years of string
    type CronExpression = Seconds * Minutes * Hours * DayOfMonth * Month * DayOfWeek * Years

    let split (expression:string):CronExpression =
        let x = expression.Trim().Split ([|' '; '\t'; '\r'; '\n'|], StringSplitOptions.RemoveEmptyEntries)
        match Array.length x with
        | 6 -> Seconds x.[0], Minutes x.[1], Hours x.[2], DayOfMonth x.[3], Month x.[4], DayOfWeek x.[5], Years "*"
        | 7 -> Seconds x.[0], Minutes x.[1], Hours x.[2], DayOfMonth x.[3], Month x.[4], DayOfWeek x.[5], Years x.[6]
        | _ -> failwith "Invalid cron expression"

    let month = Map.ofList ["JAN", 1; "FEB", 2]

    let parseMonth (Month s) =
        month.[s]

    let schedule input =
        match input with
        | _ -> { name = "" }

    let rec next expression time =
        next expression time

module Trigger =
    let startAt (date:DateTimeOffset) trigger =
        trigger

    let withSchedule schedule trigger =
        trigger

module Scheduler =
    open System

    type Scheduler = { name:string }

    let schedule trigger job scheduler = ()
    let start x =
        ()