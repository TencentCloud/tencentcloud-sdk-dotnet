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

    public class CreateLiveSnapshotTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模板名称。<br>长度上限：255字节。<br>仅支持中文、英文、数字、_、-。</p>
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// <p>Cos 应用 ID。</p>
        /// </summary>
        [JsonProperty("CosAppId")]
        public long? CosAppId{ get; set; }

        /// <summary>
        /// <p>Cos Bucket名称。<br>注：CosBucket参数值不能包含-[appid] 部分。</p>
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// <p>Cos地区。</p>
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// <p>描述信息。<br>长度上限：1024字节。<br>仅支持中文、英文、数字、_、-。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>截图间隔，单位s，默认10s。<br>范围： 2s ~ 300s。</p>
        /// </summary>
        [JsonProperty("SnapshotInterval")]
        public long? SnapshotInterval{ get; set; }

        /// <summary>
        /// <p>截图宽度。默认：0（原始宽）。<br>范围：0-3000 。</p>
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// <p>截图高度。默认：0（原始高）。<br>范围：0-2000 。</p>
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// <p>是否开启鉴黄，0：不开启，1：开启。默认：0。</p>
        /// </summary>
        [JsonProperty("PornFlag")]
        public long? PornFlag{ get; set; }

        /// <summary>
        /// <p>Cos Bucket文件夹前缀。<br>如不传，实际按默认值<br>/{Year}-{Month}-{Day}<br>生效</p>
        /// </summary>
        [JsonProperty("CosPrefix")]
        public string CosPrefix{ get; set; }

        /// <summary>
        /// <p>Cos 文件名称。<br>如不传，实际按默认值<br>{StreamID}-screenshot-{Hour}-{Minute}-{Second}-{Width}x{Height}{Ext}<br>生效</p>
        /// </summary>
        [JsonProperty("CosFileName")]
        public string CosFileName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "CosAppId", this.CosAppId);
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SnapshotInterval", this.SnapshotInterval);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "PornFlag", this.PornFlag);
            this.SetParamSimple(map, prefix + "CosPrefix", this.CosPrefix);
            this.SetParamSimple(map, prefix + "CosFileName", this.CosFileName);
        }
    }
}

