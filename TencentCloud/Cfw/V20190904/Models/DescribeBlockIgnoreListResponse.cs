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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBlockIgnoreListResponse : AbstractModel
    {
        
        /// <summary>
        /// 列表数据
        /// </summary>
        [JsonProperty("Data")]
        public BlockIgnoreRule[] Data{ get; set; }

        /// <summary>
        /// 查询结果总数，用于分页
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// 状态值，0：查询成功，非0：查询失败
        /// </summary>
        [JsonProperty("ReturnCode")]
        public long? ReturnCode{ get; set; }

        /// <summary>
        /// 状态信息，success：查询成功，fail：查询失败
        /// </summary>
        [JsonProperty("ReturnMsg")]
        public string ReturnMsg{ get; set; }

        /// <summary>
        /// 安全事件来源下拉框
        /// </summary>
        [JsonProperty("SourceList")]
        public string[] SourceList{ get; set; }

        /// <summary>
        /// 对应规则类型的数量，示例：[0,122,30,55,12,232,0]，封禁0个，IP地址122个，域名30个，威胁情报55个，资产实例12个，自定义策略232个，入侵防御规则0个
        /// </summary>
        [JsonProperty("RuleTypeDataList")]
        public long?[] RuleTypeDataList{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "ReturnCode", this.ReturnCode);
            this.SetParamSimple(map, prefix + "ReturnMsg", this.ReturnMsg);
            this.SetParamArraySimple(map, prefix + "SourceList.", this.SourceList);
            this.SetParamArraySimple(map, prefix + "RuleTypeDataList.", this.RuleTypeDataList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

