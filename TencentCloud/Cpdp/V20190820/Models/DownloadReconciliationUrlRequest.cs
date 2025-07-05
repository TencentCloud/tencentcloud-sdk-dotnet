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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DownloadReconciliationUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台应用ID
        /// </summary>
        [JsonProperty("MainAppId")]
        public string MainAppId{ get; set; }

        /// <summary>
        /// 平台代码
        /// </summary>
        [JsonProperty("AppCode")]
        public string AppCode{ get; set; }

        /// <summary>
        /// 账单日期，yyyy-MM-dd
        /// </summary>
        [JsonProperty("BillDate")]
        public string BillDate{ get; set; }

        /// <summary>
        /// 商户或者代理商ID
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MainAppId", this.MainAppId);
            this.SetParamSimple(map, prefix + "AppCode", this.AppCode);
            this.SetParamSimple(map, prefix + "BillDate", this.BillDate);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

