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

    public class SnapshotTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>模板 ID。</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// <p>模板名称。</p>
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// <p>截图时间间隔，5-300秒。</p>
        /// </summary>
        [JsonProperty("SnapshotInterval")]
        public long? SnapshotInterval{ get; set; }

        /// <summary>
        /// <p>截图宽度，范围：0-3000。<br>0：原始宽度并适配原始比例。</p>
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// <p>截图高度，范围：0-2000。<br>0：原始高度并适配原始比例。</p>
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// <p>是否开启鉴黄，0：不开启，1：开启。</p>
        /// </summary>
        [JsonProperty("PornFlag")]
        public long? PornFlag{ get; set; }

        /// <summary>
        /// <p>Cos 应用 ID。</p>
        /// </summary>
        [JsonProperty("CosAppId")]
        public long? CosAppId{ get; set; }

        /// <summary>
        /// <p>Cos Bucket名称。</p>
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// <p>Cos 地域。</p>
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// <p>模板描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Cos Bucket文件夹前缀。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosPrefix")]
        public string CosPrefix{ get; set; }

        /// <summary>
        /// <p>Cos 文件名称。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosFileName")]
        public string CosFileName{ get; set; }

        /// <summary>
        /// <p>第三方存储时账号的SecretId</p>
        /// </summary>
        [JsonProperty("CosSecretId")]
        public string CosSecretId{ get; set; }

        /// <summary>
        /// <p>第三方存储时，账号的SecretKey</p><p>当查询时，该值返回为<code>******</code></p>
        /// </summary>
        [JsonProperty("CosSecretKey")]
        public string CosSecretKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "SnapshotInterval", this.SnapshotInterval);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "PornFlag", this.PornFlag);
            this.SetParamSimple(map, prefix + "CosAppId", this.CosAppId);
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CosPrefix", this.CosPrefix);
            this.SetParamSimple(map, prefix + "CosFileName", this.CosFileName);
            this.SetParamSimple(map, prefix + "CosSecretId", this.CosSecretId);
            this.SetParamSimple(map, prefix + "CosSecretKey", this.CosSecretKey);
        }
    }
}

