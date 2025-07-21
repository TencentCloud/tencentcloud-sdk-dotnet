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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Multimedia : AbstractModel
    {
        
        /// <summary>
        /// 多媒体类型，可选值包括 image、music、album、playlist。
        /// 说明：
        /// 1. image：图片；music：单曲，类型为单曲时，会返回详细歌手和歌曲信息；album：专辑；playlist：歌单。
        /// 2. 当 type 为 music、album、playlist 时，需要配合 [QQ音乐SDK](https://developer.y.qq.com/) 使用。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 多媒体地址。
        /// 说明：
        /// 1. type 为 image 时，地址为图片的预览地址；其他类型时，地址为封面图地址。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 如果Url为图片地址，标识图片宽度。
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 如果Url为图片地址，标识图片高度。
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 多媒体详情地址。
        /// 说明：
        /// 1. 仅 type 为 image 时，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 缩略图地址。
        /// </summary>
        [JsonProperty("ThumbURL")]
        public string ThumbURL{ get; set; }

        /// <summary>
        /// 缩略图宽度
        /// </summary>
        [JsonProperty("ThumbWidth")]
        public long? ThumbWidth{ get; set; }

        /// <summary>
        /// 缩略图高度
        /// </summary>
        [JsonProperty("ThumbHeight")]
        public long? ThumbHeight{ get; set; }

        /// <summary>
        /// 名称。
        /// 说明：
        /// 1. type 为 image 时，该字段为空。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 歌手名称。
        /// 说明：
        /// 1. 仅 type 为 music 时，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Singer")]
        public string Singer{ get; set; }

        /// <summary>
        /// 歌曲详情。
        /// 说明：
        /// 1. 仅 type 为 music 时，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ext")]
        public SongExt Ext{ get; set; }

        /// <summary>
        /// 发布时间。
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [JsonProperty("SiteName")]
        public string SiteName{ get; set; }

        /// <summary>
        /// 站点图标
        /// </summary>
        [JsonProperty("SiteIcon")]
        public string SiteIcon{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamSimple(map, prefix + "ThumbURL", this.ThumbURL);
            this.SetParamSimple(map, prefix + "ThumbWidth", this.ThumbWidth);
            this.SetParamSimple(map, prefix + "ThumbHeight", this.ThumbHeight);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Singer", this.Singer);
            this.SetParamObj(map, prefix + "Ext.", this.Ext);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "SiteName", this.SiteName);
            this.SetParamSimple(map, prefix + "SiteIcon", this.SiteIcon);
        }
    }
}

