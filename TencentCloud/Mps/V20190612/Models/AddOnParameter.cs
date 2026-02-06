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

    public class AddOnParameter : AbstractModel
    {
        
        /// <summary>
        /// 附加图片输入。
        /// </summary>
        [JsonProperty("ImageSet")]
        public AddOnImageInput[] ImageSet{ get; set; }

        /// <summary>
        /// 图片处理输出配置。
        /// </summary>
        [JsonProperty("OutputConfig")]
        public ImageProcessOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// 图片处理附加 prompt，只针对某些场景可用。
        /// </summary>
        [JsonProperty("ExtPrompt")]
        public ImageProcessPrompt[] ExtPrompt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ImageSet.", this.ImageSet);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamArrayObj(map, prefix + "ExtPrompt.", this.ExtPrompt);
        }
    }
}

