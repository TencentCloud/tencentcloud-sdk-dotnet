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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SceneAigcImageTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 场景化生图参数配置。
        /// </summary>
        [JsonProperty("SceneInfo")]
        public AigcImageSceneInfo SceneInfo{ get; set; }

        /// <summary>
        /// 输入图片列表。
        /// </summary>
        [JsonProperty("FileInfos")]
        public SceneAigcImageTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// 场景化生图任务的输出媒体文件配置。
        /// </summary>
        [JsonProperty("OutputConfig")]
        public SceneAigcImageOutputConfig OutputConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SceneInfo.", this.SceneInfo);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
        }
    }
}

