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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProjectsRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台 Id，指定访问的平台。关于平台概念，请参见文档 [平台](https://cloud.tencent.com/document/product/1156/43767)。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 项目 Id 过滤参数列表，最大支持20个项目 Id 过滤。如果不填不需要项目 Id 进行过滤。
        /// </summary>
        [JsonProperty("ProjectIds")]
        public string[] ProjectIds{ get; set; }

        /// <summary>
        /// 画布宽高比过滤参数列表。如果不填则不用画布宽高比进行过滤。
        /// </summary>
        [JsonProperty("AspectRatioSet")]
        public string[] AspectRatioSet{ get; set; }

        /// <summary>
        /// 项目类型过滤参数列表，取值有：
        /// <li>VIDEO_EDIT：视频编辑。</li>
        /// <li>SWITCHER：导播台。</li>
        /// <li>VIDEO_SEGMENTATION：视频拆条。</li>
        /// <li>STREAM_CONNECT：云转推。</li>
        /// <li>RECORD_REPLAY：录制回放。</li>
        /// <li>MEDIA_CAST：点播转直播。</li>
        /// 
        /// 注：如果不填则不使用项目类型进行过滤。
        /// </summary>
        [JsonProperty("CategorySet")]
        public string[] CategorySet{ get; set; }

        /// <summary>
        /// 项目模式过滤参数列表，一个项目可以有多种模式并相互切换。
        /// 当 Category 为 VIDEO_EDIT 时，可选模式有：
        /// <li>Default：默认模式。</li>
        /// <li>VideoEditTemplate：视频编辑模板制作模式。</li>
        /// 
        /// 注：不填不使用项目模式进行过滤。
        /// </summary>
        [JsonProperty("Modes")]
        public string[] Modes{ get; set; }

        /// <summary>
        /// 结果排序方式，支持下列排序字段：
        /// <li>CreateTime：创建时间；</li>
        /// <li>UpdateTime：更新时间。</li>
        /// 
        /// 注：如不填，则使用项目创建时间倒序排列。
        /// </summary>
        [JsonProperty("Sort")]
        public SortBy Sort{ get; set; }

        /// <summary>
        /// 项目所有者，目前仅支持个人项目过滤。
        /// </summary>
        [JsonProperty("Owner")]
        public Entity Owner{ get; set; }

        /// <summary>
        /// 分页返回的起始偏移量，默认值：0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 分页返回的记录条数，默认值：10。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 操作者。如不填，默认为 `cmeid_system`，表示平台管理员操作，可以查询一切用户项目信息。如果指定操作者，则操作者必须为项目所有者。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "AspectRatioSet.", this.AspectRatioSet);
            this.SetParamArraySimple(map, prefix + "CategorySet.", this.CategorySet);
            this.SetParamArraySimple(map, prefix + "Modes.", this.Modes);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
            this.SetParamObj(map, prefix + "Owner.", this.Owner);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

