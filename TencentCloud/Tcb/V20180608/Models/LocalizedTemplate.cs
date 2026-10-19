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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LocalizedTemplate : AbstractModel
    {
        
        /// <summary>
        /// <p>中文</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZhCN")]
        public string ZhCN{ get; set; }

        /// <summary>
        /// <p>英文</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnUS")]
        public string EnUS{ get; set; }

        /// <summary>
        /// <p>中文主题</p><p>入参限制：长度限制100字符以内，仅允许：{{.VerificationCode}}、{{.Usage}}、{{.Email}}、{{.ExpireMinutes}}、{{.ConfirmationURL}}，未知变量拒绝</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubjectZhCN")]
        public string SubjectZhCN{ get; set; }

        /// <summary>
        /// <p>英文主题</p><p>入参限制：长度限制100字符以内，仅允许：{{.VerificationCode}}、{{.Usage}}、{{.Email}}、{{.ExpireMinutes}}、{{.ConfirmationURL}}，未知变量拒绝</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubjectEnUS")]
        public string SubjectEnUS{ get; set; }

        /// <summary>
        /// <p>中文发件人</p><p>入参限制：长度限制50字符以内，静态纯文本，不支持变量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SenderNameZhCN")]
        public string SenderNameZhCN{ get; set; }

        /// <summary>
        /// <p>英文发件人</p><p>默认值：长度限制50字符以内，静态纯文本，不支持变量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SenderNameEnUS")]
        public string SenderNameEnUS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZhCN", this.ZhCN);
            this.SetParamSimple(map, prefix + "EnUS", this.EnUS);
            this.SetParamSimple(map, prefix + "SubjectZhCN", this.SubjectZhCN);
            this.SetParamSimple(map, prefix + "SubjectEnUS", this.SubjectEnUS);
            this.SetParamSimple(map, prefix + "SenderNameZhCN", this.SenderNameZhCN);
            this.SetParamSimple(map, prefix + "SenderNameEnUS", this.SenderNameEnUS);
        }
    }
}

