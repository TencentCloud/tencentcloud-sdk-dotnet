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

    public class DescribePlayErrorCodeSumInfoListResponse : AbstractModel
    {
        
        /// <summary>
        /// 分省份分运营商错误码为4或5开头的状态码数据信息。
        /// </summary>
        [JsonProperty("ProIspInfoList")]
        public ProIspPlayCodeDataInfo[] ProIspInfoList{ get; set; }

        /// <summary>
        /// 所有状态码的加和的次数。
        /// </summary>
        [JsonProperty("TotalCodeAll")]
        public ulong? TotalCodeAll{ get; set; }

        /// <summary>
        /// 状态码为4开头的总次数。
        /// </summary>
        [JsonProperty("TotalCode4xx")]
        public ulong? TotalCode4xx{ get; set; }

        /// <summary>
        /// 状态码为5开头的总次数。
        /// </summary>
        [JsonProperty("TotalCode5xx")]
        public ulong? TotalCode5xx{ get; set; }

        /// <summary>
        /// 各状态码的总次数，暂时支持400,403,404,500,502,503,504。
        /// </summary>
        [JsonProperty("TotalCodeList")]
        public PlayCodeTotalInfo[] TotalCodeList{ get; set; }

        /// <summary>
        /// 页号。
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// 每页大小。
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 总页数。
        /// </summary>
        [JsonProperty("TotalPage")]
        public ulong? TotalPage{ get; set; }

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("TotalNum")]
        public ulong? TotalNum{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ProIspInfoList.", this.ProIspInfoList);
            this.SetParamSimple(map, prefix + "TotalCodeAll", this.TotalCodeAll);
            this.SetParamSimple(map, prefix + "TotalCode4xx", this.TotalCode4xx);
            this.SetParamSimple(map, prefix + "TotalCode5xx", this.TotalCode5xx);
            this.SetParamArrayObj(map, prefix + "TotalCodeList.", this.TotalCodeList);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "TotalPage", this.TotalPage);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

