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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMQTTInstanceResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例类型，
        /// EXPERIMENT 体验版
        /// BASIC 基础版
        /// PRO  专业版
        /// PLATINUM 铂金版
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 主题数量
        /// </summary>
        [JsonProperty("TopicNum")]
        public long? TopicNum{ get; set; }

        /// <summary>
        /// 实例最大主题数量
        /// </summary>
        [JsonProperty("TopicNumLimit")]
        public long? TopicNumLimit{ get; set; }

        /// <summary>
        /// TPS限流值
        /// </summary>
        [JsonProperty("TpsLimit")]
        public long? TpsLimit{ get; set; }

        /// <summary>
        /// 创建时间，秒为单位
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// 实例规格
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// 订阅数上限
        /// </summary>
        [JsonProperty("SubscriptionNumLimit")]
        public long? SubscriptionNumLimit{ get; set; }

        /// <summary>
        /// 客户端数量上限
        /// </summary>
        [JsonProperty("ClientNumLimit")]
        public long? ClientNumLimit{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "TopicNum", this.TopicNum);
            this.SetParamSimple(map, prefix + "TopicNumLimit", this.TopicNumLimit);
            this.SetParamSimple(map, prefix + "TpsLimit", this.TpsLimit);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "SubscriptionNumLimit", this.SubscriptionNumLimit);
            this.SetParamSimple(map, prefix + "ClientNumLimit", this.ClientNumLimit);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

