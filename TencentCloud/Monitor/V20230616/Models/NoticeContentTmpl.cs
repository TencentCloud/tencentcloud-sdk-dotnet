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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NoticeContentTmpl : AbstractModel
    {
        
        /// <summary>
        /// <p>自定义通知内容模板id，唯一id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TmplID")]
        public string TmplID{ get; set; }

        /// <summary>
        /// <p>自定义通知内容模板名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TmplName")]
        public string TmplName{ get; set; }

        /// <summary>
        /// <p>通知内容</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TmplContents")]
        public NoticeContentTmplItem TmplContents{ get; set; }

        /// <summary>
        /// <p>Unix时间戳，秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>Unix时间戳，秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// <p>最后修改人</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastModifier")]
        public string LastModifier{ get; set; }

        /// <summary>
        /// <p>创建人</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>监控类型</p>
        /// </summary>
        [JsonProperty("MonitorType")]
        public string MonitorType{ get; set; }

        /// <summary>
        /// <p>模板语言 en/zh</p>
        /// </summary>
        [JsonProperty("TmplLanguage")]
        public string TmplLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TmplID", this.TmplID);
            this.SetParamSimple(map, prefix + "TmplName", this.TmplName);
            this.SetParamObj(map, prefix + "TmplContents.", this.TmplContents);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "LastModifier", this.LastModifier);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamSimple(map, prefix + "TmplLanguage", this.TmplLanguage);
        }
    }
}

