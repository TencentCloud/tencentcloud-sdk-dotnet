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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMediaInfosRequest : AbstractModel
    {
        
        /// <summary>
        /// 媒体文件 ID 列表，N 从 0 开始取值，最大 19。
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 指定所有媒体文件需要返回的信息，可同时指定多个信息，N 从 0 开始递增。如果未填写该字段，默认返回所有信息。选项有：
        /// <li>basicInfo（视频基础信息）。</li>
        /// <li>metaData（视频元信息）。</li>
        /// <li>transcodeInfo（视频转码结果信息）。</li>
        /// <li>animatedGraphicsInfo（视频转动图结果信息）。</li>
        /// <li>imageSpriteInfo（视频雪碧图信息）。</li>
        /// <li>snapshotByTimeOffsetInfo（视频指定时间点截图信息）。</li>
        /// <li>sampleSnapshotInfo（采样截图信息）。</li>
        /// <li>keyFrameDescInfo（打点信息）。</li>
        /// <li>adaptiveDynamicStreamingInfo（转自适应码流信息）。</li>
        /// <li>miniProgramReviewInfo（小程序审核信息）。</li>
        /// <li>subtitleInfo（字幕信息）。</li>
        /// <li>reviewInfo（审核信息）。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public string[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamArraySimple(map, prefix + "Filters.", this.Filters);
        }
    }
}

