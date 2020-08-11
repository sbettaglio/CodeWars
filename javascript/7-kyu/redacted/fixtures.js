describe("SampleTests", function(){
    it("ex1", function(){
        var doc1 = "TOP SECRET:\nThe missile launch code for Sunday XXXXXXXXXX is:\nXXXXXXXXXXXXXXXXX";
        var doc2 = "TOP SECRET:\nThe missile launch code for Sunday 5th August is:\n7-ZERO-8X-ALPHA-1";
        Test.assertEquals(redacted(doc1, doc2), true);
    });
    it("ex2", function(){
        var doc1 = "The name of the mole is Professor XXXXX";
        var doc2 = "The name of the mole is Professor Dinglemouse";
        Test.assertEquals(redacted(doc1, doc2), false);
    });
    it("ex3", function(){
        var doc1 = "XXXXXXXX XXXXXXX XXXXXXXXXXXXXXXXXXX\nXXXX XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX XXXXXXXXX XXXXXXXXXXXXX XXXXX";
        var doc2 = "Area-51. Medical Report. 23/Oct/1969\nE.T. subject 4 was given an asprin after reporting sick for duty today";
        Test.assertEquals(redacted(doc1, doc2), true);
    });
});