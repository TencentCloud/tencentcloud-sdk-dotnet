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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquiryPriceScaleOutInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 扩容的时间单位。取值范围：
        /// <li>s：表示秒。PayMode取值为0时，TimeUnit只能取值为s。</li>
        /// <li>m：表示月份。PayMode取值为1时，TimeUnit只能取值为m。</li>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 扩容的时长。结合TimeUnit一起使用。
        /// <li>TimeUnit为s时，该参数只能填写3600，表示按量计费实例。</li>
        /// <li>TimeUnit为m时，该参数填写的数字表示包年包月实例的购买时长，如1表示购买一个月</li>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// 实例所属的可用区ID，例如100003。该参数可以通过调用 [DescribeZones](https://cloud.tencent.com/document/api/213/15707) 的返回值中的ZoneId字段来获取。
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// 实例计费模式。取值范围：
        /// <li>0：表示按量计费。</li>
        /// <li>1：表示包年包月。</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 扩容的Core节点数量。
        /// </summary>
        [JsonProperty("CoreCount")]
        public ulong? CoreCount{ get; set; }

        /// <summary>
        /// 扩容的Task节点数量。
        /// </summary>
        [JsonProperty("TaskCount")]
        public ulong? TaskCount{ get; set; }

        /// <summary>
        /// 货币种类。取值范围：
        /// <li>CNY：表示人民币。</li>
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// 扩容的Router节点数量。
        /// </summary>
        [JsonProperty("RouterCount")]
        public ulong? RouterCount{ get; set; }

        /// <summary>
        /// 扩容的Master节点数量。
        /// </summary>
        [JsonProperty("MasterCount")]
        public ulong? MasterCount{ get; set; }

        /// <summary>
        /// 类型为ComputeResource和EMR以及默认，默认为EMR
        /// </summary>
        [JsonProperty("ResourceBaseType")]
        public string ResourceBaseType{ get; set; }

        /// <summary>
        /// 计算资源id
        /// </summary>
        [JsonProperty("ComputeResourceId")]
        public string ComputeResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CoreCount", this.CoreCount);
            this.SetParamSimple(map, prefix + "TaskCount", this.TaskCount);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "RouterCount", this.RouterCount);
            this.SetParamSimple(map, prefix + "MasterCount", this.MasterCount);
            this.SetParamSimple(map, prefix + "ResourceBaseType", this.ResourceBaseType);
            this.SetParamSimple(map, prefix + "ComputeResourceId", this.ComputeResourceId);
        }
    }
}

