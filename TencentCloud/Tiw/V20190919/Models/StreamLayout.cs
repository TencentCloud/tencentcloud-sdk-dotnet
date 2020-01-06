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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StreamLayout : AbstractModel
    {
        
        /// <summary>
        /// 流布局配置参数
        /// </summary>
        [JsonProperty("LayoutParams")]
        public LayoutParams LayoutParams{ get; set; }

        /// <summary>
        /// 视频流ID
        /// 流ID的取值含义如下：
        /// 1. tic_record_user - 表示当前画面用于显示白板视频流
        /// 2. tic_substream - 表示当前画面用于显示辅路视频流
        /// 3. 特定用户ID - 表示当前画面用于显示指定用户的视频流
        /// 4. 不填 - 表示当前画面用于备选，当有新的视频流加入时，会从这些备选的空位中选择一个没有被占用的位置来显示新的视频流画面
        /// </summary>
        [JsonProperty("InputStreamId")]
        public string InputStreamId{ get; set; }

        /// <summary>
        /// 背景颜色，默认为黑色，格式为RGB格式，如红色为"#FF0000"
        /// </summary>
        [JsonProperty("BackgroundColor")]
        public string BackgroundColor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "LayoutParams.", this.LayoutParams);
            this.SetParamSimple(map, prefix + "InputStreamId", this.InputStreamId);
            this.SetParamSimple(map, prefix + "BackgroundColor", this.BackgroundColor);
        }
    }
}

