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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectDetail : AbstractModel
    {
        
        /// <summary>
        /// 请求时间戳。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReqTime")]
        public string ReqTime{ get; set; }

        /// <summary>
        /// 本次活体一比一请求的唯一标记。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Seq")]
        public string Seq{ get; set; }

        /// <summary>
        /// 参与本次活体一比一的身份证号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Idcard")]
        public string Idcard{ get; set; }

        /// <summary>
        /// 参与本次活体一比一的姓名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 本次活体一比一的相似度。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sim")]
        public string Sim{ get; set; }

        /// <summary>
        /// 本次活体一比一是否收费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsNeedCharge")]
        public bool? IsNeedCharge{ get; set; }

        /// <summary>
        /// 本次活体一比一最终结果。0为成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Errcode")]
        public long? Errcode{ get; set; }

        /// <summary>
        /// 本次活体一比一最终结果描述。（仅描述用，文案更新时不会通知。）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Errmsg")]
        public string Errmsg{ get; set; }

        /// <summary>
        /// 本次活体结果。0为成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Livestatus")]
        public long? Livestatus{ get; set; }

        /// <summary>
        /// 本次活体结果描述。（仅描述用，文案更新时不会通知。）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Livemsg")]
        public string Livemsg{ get; set; }

        /// <summary>
        /// 本次一比一结果。0为成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Comparestatus")]
        public long? Comparestatus{ get; set; }

        /// <summary>
        /// 本次一比一结果描述。（仅描述用，文案更新时不会通知。）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Comparemsg")]
        public string Comparemsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReqTime", this.ReqTime);
            this.SetParamSimple(map, prefix + "Seq", this.Seq);
            this.SetParamSimple(map, prefix + "Idcard", this.Idcard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Sim", this.Sim);
            this.SetParamSimple(map, prefix + "IsNeedCharge", this.IsNeedCharge);
            this.SetParamSimple(map, prefix + "Errcode", this.Errcode);
            this.SetParamSimple(map, prefix + "Errmsg", this.Errmsg);
            this.SetParamSimple(map, prefix + "Livestatus", this.Livestatus);
            this.SetParamSimple(map, prefix + "Livemsg", this.Livemsg);
            this.SetParamSimple(map, prefix + "Comparestatus", this.Comparestatus);
            this.SetParamSimple(map, prefix + "Comparemsg", this.Comparemsg);
        }
    }
}

