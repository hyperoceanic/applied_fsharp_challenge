
type Block = Block of int
let runB (Block block) = block

let x = Block 13

runB x


let amp amount input = input * amount

let amp (amount: float) (input: float) : float = input * amount

let amp (amount: float) =
    fun (input: float) ->
        input * amount
