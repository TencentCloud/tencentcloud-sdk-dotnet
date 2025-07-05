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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCRObtainDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 作品名称
        /// </summary>
        [JsonProperty("WorkName")]
        public string WorkName{ get; set; }

        /// <summary>
        /// 侵权链接
        /// </summary>
        [JsonProperty("TortURL")]
        public string TortURL{ get; set; }

        /// <summary>
        /// 取证时间
        /// </summary>
        [JsonProperty("ObtainTime")]
        public string ObtainTime{ get; set; }

        /// <summary>
        /// 取证类型
        /// </summary>
        [JsonProperty("ObtainType")]
        public string ObtainType{ get; set; }

        /// <summary>
        /// 取证号
        /// </summary>
        [JsonProperty("ObtainNum")]
        public string ObtainNum{ get; set; }

        /// <summary>
        /// 证据地址
        /// </summary>
        [JsonProperty("DepositFile")]
        public string DepositFile{ get; set; }

        /// <summary>
        /// 公证信息地址
        /// </summary>
        [JsonProperty("DepositCert")]
        public string DepositCert{ get; set; }

        /// <summary>
        /// 内容类型
        /// </summary>
        [JsonProperty("WorkType")]
        public string WorkType{ get; set; }

        /// <summary>
        /// 作品类型
        /// </summary>
        [JsonProperty("WorkCategory")]
        public string WorkCategory{ get; set; }

        /// <summary>
        /// 侵权ID
        /// </summary>
        [JsonProperty("TortId")]
        public long? TortId{ get; set; }

        /// <summary>
        /// 侵权编号
        /// </summary>
        [JsonProperty("TortNum")]
        public string TortNum{ get; set; }

        /// <summary>
        /// 取证状态
        /// </summary>
        [JsonProperty("ObtainStatus")]
        public long? ObtainStatus{ get; set; }

        /// <summary>
        /// 取证状态说明
        /// </summary>
        [JsonProperty("ObtainNote")]
        public string ObtainNote{ get; set; }

        /// <summary>
        /// 取证时长
        /// </summary>
        [JsonProperty("ObtainDuration")]
        public string ObtainDuration{ get; set; }

        /// <summary>
        /// 取证名称
        /// </summary>
        [JsonProperty("ObtainName")]
        public string ObtainName{ get; set; }

        /// <summary>
        /// 取证公证信息
        /// </summary>
        [JsonProperty("DepositPdfCert")]
        public string DepositPdfCert{ get; set; }

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
            this.SetParamSimple(map, prefix + "WorkName", this.WorkName);
            this.SetParamSimple(map, prefix + "TortURL", this.TortURL);
            this.SetParamSimple(map, prefix + "ObtainTime", this.ObtainTime);
            this.SetParamSimple(map, prefix + "ObtainType", this.ObtainType);
            this.SetParamSimple(map, prefix + "ObtainNum", this.ObtainNum);
            this.SetParamSimple(map, prefix + "DepositFile", this.DepositFile);
            this.SetParamSimple(map, prefix + "DepositCert", this.DepositCert);
            this.SetParamSimple(map, prefix + "WorkType", this.WorkType);
            this.SetParamSimple(map, prefix + "WorkCategory", this.WorkCategory);
            this.SetParamSimple(map, prefix + "TortId", this.TortId);
            this.SetParamSimple(map, prefix + "TortNum", this.TortNum);
            this.SetParamSimple(map, prefix + "ObtainStatus", this.ObtainStatus);
            this.SetParamSimple(map, prefix + "ObtainNote", this.ObtainNote);
            this.SetParamSimple(map, prefix + "ObtainDuration", this.ObtainDuration);
            this.SetParamSimple(map, prefix + "ObtainName", this.ObtainName);
            this.SetParamSimple(map, prefix + "DepositPdfCert", this.DepositPdfCert);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

