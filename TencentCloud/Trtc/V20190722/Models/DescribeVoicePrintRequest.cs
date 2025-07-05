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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVoicePrintRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询方式，0表示查询特定VoicePrintId，1表示分页查询
        /// </summary>
        [JsonProperty("DescribeMode")]
        public ulong? DescribeMode{ get; set; }

        /// <summary>
        /// 声纹ID
        /// </summary>
        [JsonProperty("VoicePrintIdList")]
        public string[] VoicePrintIdList{ get; set; }

        /// <summary>
        /// 当前页码,从1开始,DescribeMode为1时填写
        /// </summary>
        [JsonProperty("PageIndex")]
        public ulong? PageIndex{ get; set; }

        /// <summary>
        /// 每页条数 最少20,DescribeMode为1时填写
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DescribeMode", this.DescribeMode);
            this.SetParamArraySimple(map, prefix + "VoicePrintIdList.", this.VoicePrintIdList);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

