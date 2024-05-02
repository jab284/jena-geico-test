interface ICarnivore
{

    //didn't use abstract word as it is implied since it is interface / abstract is default
    //also don't have to use public  public is default
    /*Assumed to be abstract (traditionally, so it is implied*/
    /* Default access modifier in Interface is public because (traditionally) private would not have made sense*/ 


    int Value { get; set; }
    
    void EatMeat();  

}