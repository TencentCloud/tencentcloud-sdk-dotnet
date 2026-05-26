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

    public class AigcImageExtraParam : AbstractModel
    {
        
        /// <summary>
        /// <p>指定所生成视频的宽高比。</p><p>不同模型支持的宽高比:</p><ol><li>Kling 2.1支持：16:9、9:16、1:1、4:3、3:4、3:2、2:3、21:9。</li><li>Kling 3.0支持：16:9、9:16、1:1、4:3、3:4、3:2、2:3、21:9。</li><li>Kling 3.0-Omni支持：16:9、9:16、1:1、4:3、3:4、3:2、2:3、21:9。</li><li>Kling O1支持：16:9、9:16、1:1、4:3、3:4、3:2、2:3、21:9。</li><li>Vidu q2支持：16:9、9:16、1:1、3:4、4:3、21:9、2:3、3:2。</li><li>MJ v7的宽高比需要在 prompt 中进行指定。</li></ol><p>注：具体模型的宽高比参数，可查看相应模型官网获取更完整描述。</p>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// <p>指定图片输出分辨率。</p><p>支持该参数的模型：<br>支持选择: 720P, 1080P, 2K, 4K。</p>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>是否添加图标水印。默认不加。1-添加，0-不添加。</p><p>取值范围：[0, 1]</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// <p>指定图片的输出格式，支持jpeg, png。</p>
        /// </summary>
        [JsonProperty("OutputFormat")]
        public string OutputFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamSimple(map, prefix + "OutputFormat", this.OutputFormat);
        }
    }
}

