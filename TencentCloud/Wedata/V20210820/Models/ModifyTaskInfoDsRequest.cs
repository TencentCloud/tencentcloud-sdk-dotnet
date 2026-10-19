/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTaskInfoDsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>项目Id</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>执行时间，单位分钟，天/周/月/年调度才有。比如天调度，每天的02:00点执行一次，delayTime就是120分钟</p>
        /// </summary>
        [JsonProperty("DelayTime")]
        public long? DelayTime{ get; set; }

        /// <summary>
        /// <p>启动时间：该字段已废弃，无需填写</p>
        /// </summary>
        [JsonProperty("StartupTime")]
        public long? StartupTime{ get; set; }

        /// <summary>
        /// <p>自依赖类型  1:有序串行 一次一个 排队  2: 无序串行 一次一个 不排队 3:并行 一次多个；暂不支持其他值</p>
        /// </summary>
        [JsonProperty("SelfDepend")]
        public long? SelfDepend{ get; set; }

        /// <summary>
        /// <p>生效开始时间，格式 yyyy-MM-dd HH:mm:ss</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>生效结束时间，格式 yyyy-MM-dd HH:mm:ss</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>调度配置-弹性周期配置，小时/周/月/年调度才有，小时任务指定每天的0点3点4点跑，则为 0,3,4。设置该值时，请把CycleStep字段设置为1（如果原始值不为1）。</p>
        /// </summary>
        [JsonProperty("TaskAction")]
        public string TaskAction{ get; set; }

        /// <summary>
        /// <p>周期类型  0:crontab类型, 1:分钟，2:小时，3:天，4:周，5:月，6:一次性，7:用户驱动，10:弹性周期 周,11:弹性周期 月,12:年,13:即时触发Instant类型，与正常周期调度任务逻辑隔离</p>
        /// </summary>
        [JsonProperty("CycleType")]
        public long? CycleType{ get; set; }

        /// <summary>
        /// <p>小时和分钟任务才有；分钟任务：5、10、15、20、30，表示每隔5【或其他值】分钟执行一次；小时任务：1、2、3、4、5、6、7、8、9、10、11、12，表示每隔1【或其他值】小时执行一次。该值大于1时，请把TaskAction字段设置为空字符串。</p>
        /// </summary>
        [JsonProperty("CycleStep")]
        public long? CycleStep{ get; set; }

        /// <summary>
        /// <p>cron表达式  周期类型为crontab调度才需要</p>
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// <p>执行时间左闭区间，格式：HH:mm  小时调度才有，例如小时任务, 每日固定区间生效</p>
        /// </summary>
        [JsonProperty("ExecutionStartTime")]
        public string ExecutionStartTime{ get; set; }

        /// <summary>
        /// <p>执行时间右闭区间，格式：HH:mm  小时调度才有，例如小时任务, 每日固定区间生效</p>
        /// </summary>
        [JsonProperty("ExecutionEndTime")]
        public string ExecutionEndTime{ get; set; }

        /// <summary>
        /// <p>任务名，该字段废弃，请勿使用该字段重命名任务</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>失败重试间隔,单位分钟，创建任务的时候已经给了默认值</p>
        /// </summary>
        [JsonProperty("RetryWait")]
        public long? RetryWait{ get; set; }

        /// <summary>
        /// <p>失败重试次数，创建任务的时候已经给了默认值</p>
        /// </summary>
        [JsonProperty("TryLimit")]
        public long? TryLimit{ get; set; }

        /// <summary>
        /// <p>是否可重试，0代码不可重试，1代表可以重试；暂不支持其他值</p>
        /// </summary>
        [JsonProperty("Retriable")]
        public long? Retriable{ get; set; }

        /// <summary>
        /// <p>运行优先级，4高 5中 6低；暂不支持其他值</p>
        /// </summary>
        [JsonProperty("RunPriority")]
        public long? RunPriority{ get; set; }

        /// <summary>
        /// <p>任务的扩展配置</p>
        /// </summary>
        [JsonProperty("TaskExt")]
        public TaskExtInfo[] TaskExt{ get; set; }

        /// <summary>
        /// <p>执行资源组Id，需要去资源管理服务上创建调度资源组，并且绑定cvm机器</p>
        /// </summary>
        [JsonProperty("ResourceGroup")]
        public string ResourceGroup{ get; set; }

        /// <summary>
        /// <p>资源池队列名称</p>
        /// </summary>
        [JsonProperty("YarnQueue")]
        public string YarnQueue{ get; set; }

        /// <summary>
        /// <p>资源组下具体执行机，any 表示可以跑在任意一台。</p>
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// <p>责任人，多个责任人请用分号隔开</p>
        /// </summary>
        [JsonProperty("InCharge")]
        public string InCharge{ get; set; }

        /// <summary>
        /// <p>任务备注</p>
        /// </summary>
        [JsonProperty("Notes")]
        public string Notes{ get; set; }

        /// <summary>
        /// <p>任务参数</p>
        /// </summary>
        [JsonProperty("TaskParamInfos")]
        public ParamInfo[] TaskParamInfos{ get; set; }

        /// <summary>
        /// <p>源数据源Id</p>
        /// </summary>
        [JsonProperty("SourceServer")]
        public string SourceServer{ get; set; }

        /// <summary>
        /// <p>目标数据源Id</p>
        /// </summary>
        [JsonProperty("TargetServer")]
        public string TargetServer{ get; set; }

        /// <summary>
        /// <p>是否支持工作流依赖 yes / no 默认 no</p>
        /// </summary>
        [JsonProperty("DependencyWorkflow")]
        public string DependencyWorkflow{ get; set; }

        /// <summary>
        /// <p>依赖配置,仅可修改上游任务实例配置方法</p>
        /// </summary>
        [JsonProperty("DependencyConfigDTOs")]
        public DependencyConfig[] DependencyConfigDTOs{ get; set; }

        /// <summary>
        /// <p>运行耗时超时时间分钟数</p>
        /// </summary>
        [JsonProperty("ExecutionTTL")]
        public long? ExecutionTTL{ get; set; }

        /// <summary>
        /// <p>脚本是否改变</p>
        /// </summary>
        [JsonProperty("ScriptChange")]
        public bool? ScriptChange{ get; set; }

        /// <summary>
        /// <p>任务时区，仅支持整数时区配置</p>
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// <p>0 正常调度 1 空跑调度；暂不支持其他值</p>
        /// </summary>
        [JsonProperty("ScheduleRunType")]
        public ulong? ScheduleRunType{ get; set; }

        /// <summary>
        /// <p>0 并发度达到上限时，本次排队等待 1 并发度达到上限时，本次不执行，直接kill；暂不支持其他值</p>
        /// </summary>
        [JsonProperty("ConcurrentStrategy")]
        public ulong? ConcurrentStrategy{ get; set; }

        /// <summary>
        /// <p>shell任务发布事件</p>
        /// </summary>
        [JsonProperty("RegisterDsEventPublisherRequest")]
        public RegisterDsEventPublisherReq RegisterDsEventPublisherRequest{ get; set; }

        /// <summary>
        /// <p>base64编码后脚本内容</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>分钟任务相位偏移</p>
        /// </summary>
        [JsonProperty("MinuteOffset")]
        public ulong? MinuteOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "StartupTime", this.StartupTime);
            this.SetParamSimple(map, prefix + "SelfDepend", this.SelfDepend);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TaskAction", this.TaskAction);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "CycleStep", this.CycleStep);
            this.SetParamSimple(map, prefix + "CrontabExpression", this.CrontabExpression);
            this.SetParamSimple(map, prefix + "ExecutionStartTime", this.ExecutionStartTime);
            this.SetParamSimple(map, prefix + "ExecutionEndTime", this.ExecutionEndTime);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "RetryWait", this.RetryWait);
            this.SetParamSimple(map, prefix + "TryLimit", this.TryLimit);
            this.SetParamSimple(map, prefix + "Retriable", this.Retriable);
            this.SetParamSimple(map, prefix + "RunPriority", this.RunPriority);
            this.SetParamArrayObj(map, prefix + "TaskExt.", this.TaskExt);
            this.SetParamSimple(map, prefix + "ResourceGroup", this.ResourceGroup);
            this.SetParamSimple(map, prefix + "YarnQueue", this.YarnQueue);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "InCharge", this.InCharge);
            this.SetParamSimple(map, prefix + "Notes", this.Notes);
            this.SetParamArrayObj(map, prefix + "TaskParamInfos.", this.TaskParamInfos);
            this.SetParamSimple(map, prefix + "SourceServer", this.SourceServer);
            this.SetParamSimple(map, prefix + "TargetServer", this.TargetServer);
            this.SetParamSimple(map, prefix + "DependencyWorkflow", this.DependencyWorkflow);
            this.SetParamArrayObj(map, prefix + "DependencyConfigDTOs.", this.DependencyConfigDTOs);
            this.SetParamSimple(map, prefix + "ExecutionTTL", this.ExecutionTTL);
            this.SetParamSimple(map, prefix + "ScriptChange", this.ScriptChange);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamSimple(map, prefix + "ScheduleRunType", this.ScheduleRunType);
            this.SetParamSimple(map, prefix + "ConcurrentStrategy", this.ConcurrentStrategy);
            this.SetParamObj(map, prefix + "RegisterDsEventPublisherRequest.", this.RegisterDsEventPublisherRequest);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "MinuteOffset", this.MinuteOffset);
        }
    }
}

