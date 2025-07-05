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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateDataEngineRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源大小
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 最小资源
        /// </summary>
        [JsonProperty("MinClusters")]
        public long? MinClusters{ get; set; }

        /// <summary>
        /// 最大资源
        /// </summary>
        [JsonProperty("MaxClusters")]
        public long? MaxClusters{ get; set; }

        /// <summary>
        /// 开启自动刷新：true：开启、false（默认）：关闭
        /// </summary>
        [JsonProperty("AutoResume")]
        public bool? AutoResume{ get; set; }

        /// <summary>
        /// 数据引擎名称
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// 相关信息
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 是否自定挂起集群：false（默认）：不自动挂起、true：自动挂起
        /// </summary>
        [JsonProperty("AutoSuspend")]
        public bool? AutoSuspend{ get; set; }

        /// <summary>
        /// 定时启停集群策略：0（默认）：关闭定时策略、1：开启定时策略（注：定时启停策略与自动挂起策略互斥）
        /// </summary>
        [JsonProperty("CrontabResumeSuspend")]
        public long? CrontabResumeSuspend{ get; set; }

        /// <summary>
        /// 定时启停策略，复杂类型：包含启停时间、挂起集群策略
        /// </summary>
        [JsonProperty("CrontabResumeSuspendStrategy")]
        public CrontabResumeSuspendStrategy CrontabResumeSuspendStrategy{ get; set; }

        /// <summary>
        /// 单个集群最大并发任务数，默认5
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public long? MaxConcurrency{ get; set; }

        /// <summary>
        /// 可容忍的排队时间，默认0。当任务排队的时间超过可容忍的时间时可能会触发扩容。如果该参数为0，则表示一旦有任务排队就可能立即触发扩容。
        /// </summary>
        [JsonProperty("TolerableQueueTime")]
        public long? TolerableQueueTime{ get; set; }

        /// <summary>
        /// 集群自动挂起时间
        /// </summary>
        [JsonProperty("AutoSuspendTime")]
        public long? AutoSuspendTime{ get; set; }

        /// <summary>
        /// spark jar 包年包月集群是否开启弹性
        /// </summary>
        [JsonProperty("ElasticSwitch")]
        public bool? ElasticSwitch{ get; set; }

        /// <summary>
        /// spark jar 包年包月集群弹性上限
        /// </summary>
        [JsonProperty("ElasticLimit")]
        public long? ElasticLimit{ get; set; }

        /// <summary>
        /// Spark批作业集群Session资源配置模板
        /// </summary>
        [JsonProperty("SessionResourceTemplate")]
        public SessionResourceTemplate SessionResourceTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "MinClusters", this.MinClusters);
            this.SetParamSimple(map, prefix + "MaxClusters", this.MaxClusters);
            this.SetParamSimple(map, prefix + "AutoResume", this.AutoResume);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "AutoSuspend", this.AutoSuspend);
            this.SetParamSimple(map, prefix + "CrontabResumeSuspend", this.CrontabResumeSuspend);
            this.SetParamObj(map, prefix + "CrontabResumeSuspendStrategy.", this.CrontabResumeSuspendStrategy);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
            this.SetParamSimple(map, prefix + "TolerableQueueTime", this.TolerableQueueTime);
            this.SetParamSimple(map, prefix + "AutoSuspendTime", this.AutoSuspendTime);
            this.SetParamSimple(map, prefix + "ElasticSwitch", this.ElasticSwitch);
            this.SetParamSimple(map, prefix + "ElasticLimit", this.ElasticLimit);
            this.SetParamObj(map, prefix + "SessionResourceTemplate.", this.SessionResourceTemplate);
        }
    }
}

