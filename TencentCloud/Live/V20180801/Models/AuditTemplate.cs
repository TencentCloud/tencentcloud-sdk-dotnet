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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditTemplate : AbstractModel
    {
        
        /// <summary>
        /// <p>模板 ID 。<br>CreateAuditTemplate 时，此参数不传或传 0 。</p><p>ModifyAuditTemplate 时，此参数必传。</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// <p>模板名称。<br>CreateAuditTemplate 必填。</p>
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// <p>描述信息。<br>CreateAuditTemplate 必填。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Cos Bucket名称。<br>CreateAuditTemplate 必填。</p>
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// <p>Cos 地域。<br>CreateAuditTemplate 必填。</p>
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// <p>Cos 完整文件名（包括前缀）。CreateAuditTemplate 必填。</p>
        /// </summary>
        [JsonProperty("CosFilePath")]
        public string CosFilePath{ get; set; }

        /// <summary>
        /// <p>是否启用图片审核。<br>CreateAuditTemplate 必填。</p>
        /// </summary>
        [JsonProperty("AuditImage")]
        public bool? AuditImage{ get; set; }

        /// <summary>
        /// <p>是否启用音频审核。<br>CreateAuditTemplate 必填。</p>
        /// </summary>
        [JsonProperty("AuditAudio")]
        public bool? AuditAudio{ get; set; }

        /// <summary>
        /// <p>截图间隔，1-60秒。<br>CreateAuditTemplate 必填。</p>
        /// </summary>
        [JsonProperty("SnapshotInterval")]
        public long? SnapshotInterval{ get; set; }

        /// <summary>
        /// <p>音频间隔，1-60秒。<br>CreateAuditTemplate 必填。</p>
        /// </summary>
        [JsonProperty("AudioInterval")]
        public long? AudioInterval{ get; set; }

        /// <summary>
        /// <p>是否开启 Cos 容灾。<br>CreateAuditTemplate 必填。</p>
        /// </summary>
        [JsonProperty("EnableFailoverCos")]
        public bool? EnableFailoverCos{ get; set; }

        /// <summary>
        /// <p>容灾 Cos Bucket 。<br>CreateAuditTemplate 必填。</p>
        /// </summary>
        [JsonProperty("FailoverCosBucket")]
        public string FailoverCosBucket{ get; set; }

        /// <summary>
        /// <p>容灾 Cos 地域。<br>CreateAuditTemplate 必填。</p>
        /// </summary>
        [JsonProperty("FailoverCosRegion")]
        public string FailoverCosRegion{ get; set; }

        /// <summary>
        /// <p>场景策略配置信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SceneInfos")]
        public CMSSceneDetail[] SceneInfos{ get; set; }

        /// <summary>
        /// <p>1：表示启用音频文本识别。0 ：不启用。默认 0 。</p>
        /// </summary>
        [JsonProperty("AuditText")]
        public long? AuditText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "CosFilePath", this.CosFilePath);
            this.SetParamSimple(map, prefix + "AuditImage", this.AuditImage);
            this.SetParamSimple(map, prefix + "AuditAudio", this.AuditAudio);
            this.SetParamSimple(map, prefix + "SnapshotInterval", this.SnapshotInterval);
            this.SetParamSimple(map, prefix + "AudioInterval", this.AudioInterval);
            this.SetParamSimple(map, prefix + "EnableFailoverCos", this.EnableFailoverCos);
            this.SetParamSimple(map, prefix + "FailoverCosBucket", this.FailoverCosBucket);
            this.SetParamSimple(map, prefix + "FailoverCosRegion", this.FailoverCosRegion);
            this.SetParamArrayObj(map, prefix + "SceneInfos.", this.SceneInfos);
            this.SetParamSimple(map, prefix + "AuditText", this.AuditText);
        }
    }
}

