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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLinkRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台 Id，指定访问的平台。关于平台概念，请参见文档 [平台](https://cloud.tencent.com/document/product/1156/43767)。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 链接类型，可取值有:
        /// <li>CLASS: 分类链接；</li>
        /// <li> MATERIAL：媒体文件链接。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 链接名称，不能超过30个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 链接归属者。
        /// </summary>
        [JsonProperty("Owner")]
        public Entity Owner{ get; set; }

        /// <summary>
        /// 目标资源Id。可取值有：
        /// <li>当 Type 为 MATERIAL 时填媒体 ID；</li>
        /// <li>当 Type 为 CLASS 时填写分类路径。</li>
        /// </summary>
        [JsonProperty("DestinationId")]
        public string DestinationId{ get; set; }

        /// <summary>
        /// 目标资源归属者。
        /// </summary>
        [JsonProperty("DestinationOwner")]
        public Entity DestinationOwner{ get; set; }

        /// <summary>
        /// 链接的分类路径，如填"/a/b"则代表链接属于该分类路径，不填则默认为根路径。
        /// </summary>
        [JsonProperty("ClassPath")]
        public string ClassPath{ get; set; }

        /// <summary>
        /// 操作者。如不填，默认为 `cmeid_system`，表示平台管理员操作，可以创建任意源及目标资源的链接。如果指定操作者，则操作者必须对源资源有读权限，对目标媒体有写权限。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Owner.", this.Owner);
            this.SetParamSimple(map, prefix + "DestinationId", this.DestinationId);
            this.SetParamObj(map, prefix + "DestinationOwner.", this.DestinationOwner);
            this.SetParamSimple(map, prefix + "ClassPath", this.ClassPath);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

