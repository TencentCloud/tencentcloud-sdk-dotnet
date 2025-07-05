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

namespace TencentCloud.Hasim.V20210716.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TeleOperatorCard : AbstractModel
    {
        
        /// <summary>
        /// 开户时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountTime")]
        public string AccountTime{ get; set; }

        /// <summary>
        /// 激活时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActiveTime")]
        public string ActiveTime{ get; set; }

        /// <summary>
        /// 运营商ICCID
        /// </summary>
        [JsonProperty("ICCID")]
        public string ICCID{ get; set; }

        /// <summary>
        /// 云兔卡ID
        /// </summary>
        [JsonProperty("LinkID")]
        public long? LinkID{ get; set; }

        /// <summary>
        /// 电话号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Msisdn")]
        public string Msisdn{ get; set; }

        /// <summary>
        /// 移动用户识别码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IMSI")]
        public string IMSI{ get; set; }

        /// <summary>
        /// 运营商: 1 移动 2 联通 3 电信
        /// </summary>
        [JsonProperty("TeleOperator")]
        public long? TeleOperator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountTime", this.AccountTime);
            this.SetParamSimple(map, prefix + "ActiveTime", this.ActiveTime);
            this.SetParamSimple(map, prefix + "ICCID", this.ICCID);
            this.SetParamSimple(map, prefix + "LinkID", this.LinkID);
            this.SetParamSimple(map, prefix + "Msisdn", this.Msisdn);
            this.SetParamSimple(map, prefix + "IMSI", this.IMSI);
            this.SetParamSimple(map, prefix + "TeleOperator", this.TeleOperator);
        }
    }
}

