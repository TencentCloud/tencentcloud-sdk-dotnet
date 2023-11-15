/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class CreateDataEngineRequest : AbstractModel
    {
        
        /// <summary>
        /// 引擎类型spark/presto
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// 虚拟集群名称
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// 集群类型 spark_private/presto_private/presto_cu/spark_cu
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 计费模式 0=共享模式 1=按量计费 2=包年包月
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 是否自动启动集群
        /// </summary>
        [JsonProperty("AutoResume")]
        public bool? AutoResume{ get; set; }

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
        /// 是否为默认虚拟集群
        /// </summary>
        [JsonProperty("DefaultDataEngine")]
        [System.Obsolete]
        public bool? DefaultDataEngine{ get; set; }

        /// <summary>
        /// VPC网段
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 集群规模
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 计费类型，后付费：0，预付费：1。当前只支持后付费，不填默认为后付费。
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 资源使用时长，后付费：固定填3600，预付费：最少填1，代表购买资源一个月，最长不超过120。默认1
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 资源使用时长的单位，后付费：s，预付费：m。默认为s
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 资源的自动续费标志。后付费无需续费，固定填0；预付费下：0表示手动续费、1代表自动续费、2代表不续费，在0下如果是大客户，会自动帮大客户续费。默认为0
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }

        /// <summary>
        /// 创建资源的时候需要绑定的标签信息
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

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
        /// 引擎执行任务类型，有效值：SQL/BATCH，默认为SQL
        /// </summary>
        [JsonProperty("EngineExecType")]
        public string EngineExecType{ get; set; }

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
        /// 集群自动挂起时间，默认10分钟
        /// </summary>
        [JsonProperty("AutoSuspendTime")]
        public long? AutoSuspendTime{ get; set; }

        /// <summary>
        /// 资源类型。Standard_CU：标准型；Memory_CU：内存型
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 集群高级配置
        /// </summary>
        [JsonProperty("DataEngineConfigPairs")]
        public DataEngineConfigPair[] DataEngineConfigPairs{ get; set; }

        /// <summary>
        /// 集群镜像版本名字。如SuperSQL-P 1.1;SuperSQL-S 3.2等,不传，默认创建最新镜像版本的集群
        /// </summary>
        [JsonProperty("ImageVersionName")]
        public string ImageVersionName{ get; set; }

        /// <summary>
        /// 主集群名称，创建容灾集群时指定
        /// </summary>
        [JsonProperty("MainClusterName")]
        public string MainClusterName{ get; set; }

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
        /// spark作业集群session资源配置模板
        /// </summary>
        [JsonProperty("SessionResourceTemplate")]
        public SessionResourceTemplate SessionResourceTemplate{ get; set; }

        /// <summary>
        /// 自动授权
        /// </summary>
        [JsonProperty("AutoAuthorization")]
        public bool? AutoAuthorization{ get; set; }

        /// <summary>
        /// 引擎网络ID
        /// </summary>
        [JsonProperty("EngineNetworkId")]
        public string EngineNetworkId{ get; set; }

        /// <summary>
        /// 引擎世代，SuperSQL：代表supersql引擎，Native：代表标准引擎。默认值为SuperSQL
        /// </summary>
        [JsonProperty("EngineGeneration")]
        public string EngineGeneration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "AutoResume", this.AutoResume);
            this.SetParamSimple(map, prefix + "MinClusters", this.MinClusters);
            this.SetParamSimple(map, prefix + "MaxClusters", this.MaxClusters);
            this.SetParamSimple(map, prefix + "DefaultDataEngine", this.DefaultDataEngine);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoSuspend", this.AutoSuspend);
            this.SetParamSimple(map, prefix + "CrontabResumeSuspend", this.CrontabResumeSuspend);
            this.SetParamObj(map, prefix + "CrontabResumeSuspendStrategy.", this.CrontabResumeSuspendStrategy);
            this.SetParamSimple(map, prefix + "EngineExecType", this.EngineExecType);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
            this.SetParamSimple(map, prefix + "TolerableQueueTime", this.TolerableQueueTime);
            this.SetParamSimple(map, prefix + "AutoSuspendTime", this.AutoSuspendTime);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamArrayObj(map, prefix + "DataEngineConfigPairs.", this.DataEngineConfigPairs);
            this.SetParamSimple(map, prefix + "ImageVersionName", this.ImageVersionName);
            this.SetParamSimple(map, prefix + "MainClusterName", this.MainClusterName);
            this.SetParamSimple(map, prefix + "ElasticSwitch", this.ElasticSwitch);
            this.SetParamSimple(map, prefix + "ElasticLimit", this.ElasticLimit);
            this.SetParamObj(map, prefix + "SessionResourceTemplate.", this.SessionResourceTemplate);
            this.SetParamSimple(map, prefix + "AutoAuthorization", this.AutoAuthorization);
            this.SetParamSimple(map, prefix + "EngineNetworkId", this.EngineNetworkId);
            this.SetParamSimple(map, prefix + "EngineGeneration", this.EngineGeneration);
        }
    }
}

