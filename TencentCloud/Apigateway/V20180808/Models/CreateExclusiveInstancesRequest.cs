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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateExclusiveInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// 实例类型：     
        /// basic：            基础版
        /// professional： 专业版
        /// enterprise：     企业版
        /// platium：         铂金版
        /// diamond：       钻石版
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 网络配置
        /// </summary>
        [JsonProperty("NetworkConfig")]
        public InstanceNetworkConfig NetworkConfig{ get; set; }

        /// <summary>
        /// VPC配置
        /// </summary>
        [JsonProperty("VpcConfig")]
        public VpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// 付费类型：
        /// POSTPAID：后付费
        /// PREPAID： 预付费
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 实例名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例描述
        /// </summary>
        [JsonProperty("InstanceDescription")]
        public string InstanceDescription{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 预付费付费时长：单位是月
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 预付费续费标志：
        /// NOTIFY_AND_MANUAL_RENEW 手动续费
        /// NOTIFY_AND_AUTO_RENEW 自动续费
        /// DISABLE_NOTIFY_AND_MANUAL_RENEW 不续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public string AutoRenewFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "NetworkConfig.", this.NetworkConfig);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceDescription", this.InstanceDescription);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
        }
    }
}

