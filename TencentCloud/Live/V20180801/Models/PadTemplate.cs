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

    public class PadTemplate : AbstractModel
    {
        
        /// <summary>
        /// 模板id。
        /// </summary>
        [JsonProperty("TemplateId")]
        public ulong? TemplateId{ get; set; }

        /// <summary>
        /// 模板名称。
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 垫片内容。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 模板创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 模板修改时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 模板描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 断流等待时间。
        /// 取值范围：0-30000。
        /// 单位：ms。
        /// </summary>
        [JsonProperty("WaitDuration")]
        public ulong? WaitDuration{ get; set; }

        /// <summary>
        /// 最大垫片时长。
        /// 取值范围：0 - 正无穷。
        /// 单位：ms。
        /// </summary>
        [JsonProperty("MaxDuration")]
        public ulong? MaxDuration{ get; set; }

        /// <summary>
        /// 垫片内容类型： 1：图片，2：视频。 默认值：1。
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "WaitDuration", this.WaitDuration);
            this.SetParamSimple(map, prefix + "MaxDuration", this.MaxDuration);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

