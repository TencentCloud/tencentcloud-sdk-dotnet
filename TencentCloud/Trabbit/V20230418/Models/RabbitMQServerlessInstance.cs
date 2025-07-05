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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQServerlessInstance : AbstractModel
    {
        
        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例版本号
        /// </summary>
        [JsonProperty("InstanceVersion")]
        public string InstanceVersion{ get; set; }

        /// <summary>
        /// 实例状态，0表示创建中，1表示正常，2表示隔离中，3表示已销毁，4 - 异常, 5 - 发货失败
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// TPS
        /// </summary>
        [JsonProperty("MaxTps")]
        public long? MaxTps{ get; set; }

        /// <summary>
        /// 带宽
        /// </summary>
        [JsonProperty("MaxBandWidth")]
        public long? MaxBandWidth{ get; set; }

        /// <summary>
        /// 集群过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// 自动续费标记，0表示默认状态(用户未设置，即初始状态即手动续费)， 1表示自动续费，2表示明确不自动续费(用户设置)
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 0-后付费，1-预付费
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 集群规格
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        [JsonProperty("ExceptionInformation")]
        public string ExceptionInformation{ get; set; }

        /// <summary>
        /// 公网接入点
        /// </summary>
        [JsonProperty("PublicAccessEndpoint")]
        public string PublicAccessEndpoint{ get; set; }

        /// <summary>
        /// 私有网络接入点
        /// </summary>
        [JsonProperty("Vpcs")]
        public RabbitMQServerlessEndpoint[] Vpcs{ get; set; }

        /// <summary>
        /// 实例状态，0表示创建中，1表示正常，2表示隔离中，3表示已销毁，4 - 异常, 5 - 发货失败
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public long? ClusterStatus{ get; set; }

        /// <summary>
        /// 集群类型：1
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 为了兼容托管版，固定值 0
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }

        /// <summary>
        /// 为了兼容托管版，固定值 0
        /// </summary>
        [JsonProperty("MaxStorage")]
        public long? MaxStorage{ get; set; }

        /// <summary>
        /// 隔离时间
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public ulong? IsolatedTime{ get; set; }

        /// <summary>
        /// Serverless 扩展字段
        /// </summary>
        [JsonProperty("ServerlessExt")]
        public string ServerlessExt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceVersion", this.InstanceVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MaxTps", this.MaxTps);
            this.SetParamSimple(map, prefix + "MaxBandWidth", this.MaxBandWidth);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "ExceptionInformation", this.ExceptionInformation);
            this.SetParamSimple(map, prefix + "PublicAccessEndpoint", this.PublicAccessEndpoint);
            this.SetParamArrayObj(map, prefix + "Vpcs.", this.Vpcs);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "MaxStorage", this.MaxStorage);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "ServerlessExt", this.ServerlessExt);
        }
    }
}

