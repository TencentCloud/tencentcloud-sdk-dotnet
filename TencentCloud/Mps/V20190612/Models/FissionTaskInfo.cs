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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FissionTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>视频输出时长</p><p>取值范围：[4, 15]</p><p>单位：秒</p><p>默认值：15</p>
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// <p>模型档位</p><p>枚举值：</p><ul><li>standard： 标准版</li><li>flagship： 旗舰版</li></ul>
        /// </summary>
        [JsonProperty("ModelTier")]
        public string ModelTier{ get; set; }

        /// <summary>
        /// <p>视频画面比例</p><p>枚举值：</p><ul><li>9:16： 9:16</li><li>16:9： 16:9</li><li>1:1： 1:1</li><li>3:4： 3:4</li><li>4:3： 4:3</li></ul>
        /// </summary>
        [JsonProperty("Ratio")]
        public string Ratio{ get; set; }

        /// <summary>
        /// <p>输出分辨率</p><p>枚举值：</p><ul><li>720p： 720p</li><li>1080p： 1080p</li><li>2k： 2k</li><li>4k： 4k</li></ul>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>目标市场</p><p>枚举值：</p><ul><li>north_america： 北美</li><li>europe： 欧洲</li><li>china： 中国</li><li>japan： 日本</li><li>korea： 韩国</li><li>southeast_asia： 东南亚</li><li>brazil： 巴西</li><li>global： 全球</li><li>other： 其他</li></ul><p>影响默认出镜模特族裔与本地化风格；未指定 CustomModel 时按市场自动决定人种</p>
        /// </summary>
        [JsonProperty("Market")]
        public string Market{ get; set; }

        /// <summary>
        /// <p>口播/字幕语言</p><p>枚举值：</p><ul><li>english： 英文</li><li>chinese： 中文</li><li>japanese： 日语</li><li>korean： 韩语</li><li>spanish： 西班牙语</li><li>portuguese： 葡萄牙语</li><li>music_only： 纯音乐无口播</li></ul>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>视频类型</p><p>枚举值：</p><ul><li>ugc： UGC种草</li><li>talk： 产品口播</li><li>display： 产品展示（纯商品、无人声）</li><li>unboxing： 开箱分享</li><li>reaction： 反应展示</li></ul>
        /// </summary>
        [JsonProperty("VideoType")]
        public string VideoType{ get; set; }

        /// <summary>
        /// <p>裂变数量</p><p>取值范围：[0, 1]</p><p>单位：个</p>
        /// </summary>
        [JsonProperty("SplitCount")]
        public ulong? SplitCount{ get; set; }

        /// <summary>
        /// <p>定制出镜模特</p>
        /// </summary>
        [JsonProperty("CustomModel")]
        public CustomModel CustomModel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ModelTier", this.ModelTier);
            this.SetParamSimple(map, prefix + "Ratio", this.Ratio);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "Market", this.Market);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "VideoType", this.VideoType);
            this.SetParamSimple(map, prefix + "SplitCount", this.SplitCount);
            this.SetParamObj(map, prefix + "CustomModel.", this.CustomModel);
        }
    }
}

