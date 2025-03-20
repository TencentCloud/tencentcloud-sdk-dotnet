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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntentionQuestionResult : AbstractModel
    {
        
        /// <summary>
        /// 视频base64（其中包含全程问题和回答音频，mp4格式）
        /// 
        /// 注：`需进行base64解码获取视频文件`
        /// </summary>
        [JsonProperty("Video")]
        public string Video{ get; set; }

        /// <summary>
        ///  和答案匹配结果列表
        /// </summary>
        [JsonProperty("ResultCode")]
        public string[] ResultCode{ get; set; }

        /// <summary>
        /// 回答问题语音识别结果列表
        /// </summary>
        [JsonProperty("AsrResult")]
        public string[] AsrResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Video", this.Video);
            this.SetParamArraySimple(map, prefix + "ResultCode.", this.ResultCode);
            this.SetParamArraySimple(map, prefix + "AsrResult.", this.AsrResult);
        }
    }
}

