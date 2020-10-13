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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNatRuleOverviewResponse : AbstractModel
    {
        
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
        /// 弹性IP列表
        /// </summary>
        [JsonProperty("EipList")]
        public string[] EipList{ get; set; }

        /// <summary>
        /// 端口转发规则数量
        /// </summary>
        [JsonProperty("DnatNum")]
        public long? DnatNum{ get; set; }

        /// <summary>
        /// 访问控制规则总数
        /// </summary>
        [JsonProperty("TotalNum")]
        public long? TotalNum{ get; set; }

        /// <summary>
        /// 访问规则剩余条数
        /// </summary>
        [JsonProperty("RemainNum")]
        public long? RemainNum{ get; set; }

        /// <summary>
        /// 阻断规则条数
        /// </summary>
        [JsonProperty("BlockNum")]
        public long? BlockNum{ get; set; }

        /// <summary>
        /// 启用规则条数
        /// </summary>
        [JsonProperty("EnableNum")]
        public long? EnableNum{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArraySimple(map, prefix + "EipList.", this.EipList);
            this.SetParamSimple(map, prefix + "DnatNum", this.DnatNum);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "RemainNum", this.RemainNum);
            this.SetParamSimple(map, prefix + "BlockNum", this.BlockNum);
            this.SetParamSimple(map, prefix + "EnableNum", this.EnableNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

