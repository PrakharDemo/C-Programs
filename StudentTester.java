
public class StudentTester
{
	public static void main(String[] args) 
	{
		Student student1 = new Student();
		Student student2 = new Student();
		
		student1.setName("Jacob");
		student1.setStudentId(1001);
		student1.setQualifyingExamMarks(80.0f);
		student1.setResidentialStatus('H');
		student1.setYearOfEngg(3);
		
		student2.setName("Peter");
		student2.setStudentId(1002);
		student2.setQualifyingExamMarks(83.0f);
		student2.setResidentialStatus('D');
		student2.setYearOfEngg(2);
		
		System.out.println("*************Student Information*************");
		System.out.println("\t Student Name \t \t : " + student1.getName());
		System.out.println("\t Student Id \t \t : " + student1.getStudentId());
		System.out.println("\t Qualifying Exam Marks \t : " + student1.getQualifyingExamMarks());
		System.out.println("\t Residential Status \t : " + student1.getResidentialStatus());
		System.out.println("\t Year of Engg \t \t : " + student1.getYearOfEngg());
		System.out.println();
		
		
		System.out.println("*************Student Information*************");
		System.out.println("\t Student Name \t \t : " + student2.getName());
		System.out.println("\t Student Id \t \t : " + student2.getStudentId());
		System.out.println("\t Qualifying Exam Marks \t : " + student2.getQualifyingExamMarks());
		System.out.println("\t Residential Status \t : " + student2.getResidentialStatus());
		System.out.println("\t Year of Engg \t \t : " + student2.getYearOfEngg());
	}

}