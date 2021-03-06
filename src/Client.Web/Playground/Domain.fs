﻿namespace Client.Playground

open Tetris.Core
open System


type State =
    { Events: Event list
      Playground: Playground
      StartTime: DateTime option
      IsReplaying: bool }


type Msg =
    | Start
    | Tick
    | NewEvent of Event
    | ReplayEvent of eventIndex: int
