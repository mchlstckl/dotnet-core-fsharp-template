module Test

open Xunit
open Library

/// This will fail on macOS
/// https://github.com/xunit/xunit/issues/859
[<Fact>]    
let ``Library converts "Banana" correctly``() =
    let expected = """I used to be Banana but now I'm "Banana"!"""
    let actual =  getJsonNetJson "Banana"
    Assert.Equal(expected, actual)