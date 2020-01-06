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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTopClientIpSumInfoListResponse : AbstractModel
    {
        
        /// <summary>
        /// 页号，范围是[1,1000]，默认值是1。
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// 每页个数，范围是[1,1000]，默认值是20。
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 排序指标，可选值包括”TotalRequest”，”FailedRequest”,“TotalFlux”。
        /// </summary>
        [JsonProperty("OrderParam")]
        public string OrderParam{ get; set; }

        /// <summary>
        /// 记录总数。
        /// </summary>
        [JsonProperty("TotalNum")]
        public ulong? TotalNum{ get; set; }

        /// <summary>
        /// 记录总页数。
        /// </summary>
        [JsonProperty("TotalPage")]
        public ulong? TotalPage{ get; set; }

        /// <summary>
        /// 数据内容。
        /// </summary>
        [JsonProperty("DataInfoList")]
        public ClientIpPlaySumInfo[] DataInfoList{ get; set; }

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
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "OrderParam", this.OrderParam);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "TotalPage", this.TotalPage);
            this.SetParamArrayObj(map, prefix + "DataInfoList.", this.DataInfoList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

