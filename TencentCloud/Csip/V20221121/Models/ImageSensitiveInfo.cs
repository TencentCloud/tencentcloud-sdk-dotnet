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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageSensitiveInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>敏感信息行为类型</p><p>枚举值：</p><ul><li>1： 以root账号启动</li><li>2： 代码泄露</li><li>3： 凭据泄露</li></ul>
        /// </summary>
        [JsonProperty("Behavior")]
        public ulong? Behavior{ get; set; }

        /// <summary>
        /// <p>规则类型</p>
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// <p>风险级别</p><p>枚举值：</p><ul><li>1： 低风险</li><li>2： 中分线</li><li>3： 高风险</li><li>4： 严重风险</li></ul>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>风险描述</p>
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// <p>风险内容</p>
        /// </summary>
        [JsonProperty("InstructionContent")]
        public string InstructionContent{ get; set; }

        /// <summary>
        /// <p>镜像id</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>所属账号名</p>
        /// </summary>
        [JsonProperty("OwnerAccountName")]
        public string OwnerAccountName{ get; set; }

        /// <summary>
        /// <p>所属账号uin</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>所属账号appid</p>
        /// </summary>
        [JsonProperty("OwnerAppId")]
        public ulong? OwnerAppId{ get; set; }

        /// <summary>
        /// <p>影响镜像数</p>
        /// </summary>
        [JsonProperty("AffectImageCount")]
        public ulong? AffectImageCount{ get; set; }

        /// <summary>
        /// <p>镜像层Id</p>
        /// </summary>
        [JsonProperty("LayerId")]
        public string LayerId{ get; set; }

        /// <summary>
        /// <p>镜像Id</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>首次发现时间</p><p>参数格式：YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("FirstFoundTime")]
        public string FirstFoundTime{ get; set; }

        /// <summary>
        /// <p>最近发现时间</p><p>参数格式：YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("LatestFoundTime")]
        public string LatestFoundTime{ get; set; }

        /// <summary>
        /// <p>镜像层序号</p>
        /// </summary>
        [JsonProperty("LayerIndex")]
        public ulong? LayerIndex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Behavior", this.Behavior);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "InstructionContent", this.InstructionContent);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "OwnerAccountName", this.OwnerAccountName);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OwnerAppId", this.OwnerAppId);
            this.SetParamSimple(map, prefix + "AffectImageCount", this.AffectImageCount);
            this.SetParamSimple(map, prefix + "LayerId", this.LayerId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "FirstFoundTime", this.FirstFoundTime);
            this.SetParamSimple(map, prefix + "LatestFoundTime", this.LatestFoundTime);
            this.SetParamSimple(map, prefix + "LayerIndex", this.LayerIndex);
        }
    }
}

