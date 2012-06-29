/// <summary>
/// Task manager.
/// 
/// Written By Michael LaGrange
/// June 15th, 2012
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TaskManager {

	public Queue<Task> TaskQueue
	{
		get {return _taskQueue;}
	}
	private Queue<Task> _taskQueue;
	
	public TaskManager()
	{
		_currentTask = null;
		_taskQueue = new Queue<Task>();
	}
	
	public Task CurrentTask
	{
		get {return _currentTask;}
	}
	private Task _currentTask;
	
	
	public bool AddTask(Task task)
	{
		_taskQueue.Enqueue(task);
		if(_currentTask == null)
		{
			_currentTask = _taskQueue.Peek();
		}
		return true;
	}
	
	public bool ExecuteTask()
	{
		if(_currentTask != null)
		{
			_currentTask.DoTask();
			return true;
		}
		return false;
	}

	
	private bool nextTask()
	{
		_currentTask = null;
		if(_taskQueue.Count > 0)
		{
			_taskQueue.Dequeue();
			if(_taskQueue.Count > 0)
				_currentTask = _taskQueue.Peek();
			return true;
		}
		
		return false;
	}
	
}
