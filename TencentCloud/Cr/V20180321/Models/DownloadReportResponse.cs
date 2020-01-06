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

namespace TencentCloud.Cr.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DownloadReportResponse : AbstractModel
    {
        
        /// <summary>
        /// 到期/逾期提醒日报下载地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DailyReportUrl")]
        public string DailyReportUrl{ get; set; }

        /// <summary>
        /// 到期/逾期提醒结果下载地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultReportUrl")]
        public string ResultReportUrl{ get; set; }

        /// <summary>
        /// 到期/逾期提醒明细下载地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetailReportUrl")]
        public string DetailReportUrl{ get; set; }

        /// <summary>
        /// 回访日报下载地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CallbackDailyReportUrl")]
        public string CallbackDailyReportUrl{ get; set; }

        /// <summary>
        /// 回访结果下载地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CallbackResultReportUrl")]
        public string CallbackResultReportUrl{ get; set; }

        /// <summary>
        /// 回访明细下载地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CallbackDetailReportUrl")]
        public string CallbackDetailReportUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "DailyReportUrl", this.DailyReportUrl);
            this.SetParamSimple(map, prefix + "ResultReportUrl", this.ResultReportUrl);
            this.SetParamSimple(map, prefix + "DetailReportUrl", this.DetailReportUrl);
            this.SetParamSimple(map, prefix + "CallbackDailyReportUrl", this.CallbackDailyReportUrl);
            this.SetParamSimple(map, prefix + "CallbackResultReportUrl", this.CallbackResultReportUrl);
            this.SetParamSimple(map, prefix + "CallbackDetailReportUrl", this.CallbackDetailReportUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

