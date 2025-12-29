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

    public class AigcVideoExtraParam : AbstractModel
    {
        
        /// <summary>
        /// 生成视频的分辨率，分辨率与选择模型及设置的视频时长相关。 
        /// 
        /// 不同模型支持的分辨率选项:
        /// 1. Kling 720P(默认), 1080P。
        /// 2. Hailuo 768P(默认), 1080P。
        /// 3. Jimeng 1080P(默认)。
        /// 4. Vidu 720P(默认)，1080P。
        /// 5. GV 720P(默认),1080P。
        /// 6. OS 720P, 图片仅支持1280x720、720x1280，暂不支持指定。
        /// 
        /// 注意：除模型可支持的分辨率外，还可以生成 2K、4K分辨率。
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 指定所生成视频的宽高比。 
        /// 
        /// 不同模型对于此参数的支持：
        /// 1. Kling 仅文生视频支持, 16:9(默认值)、9:16、 1:1。
        /// 2. Hailuo 暂不支持。
        /// 3. Jimeng ["16:9"、"4:3"、"1:1"、"3:4"、"9:16"、"21:9"]
        /// 4. Vidu 仅文生和参考图生视频 支持[16:9、9:16、4:3、3:4、1:1]，其中仅q2支持4:3、3:4。
        /// 5. GV 16:9(默认值)、9:16。
        /// 6. OS 仅文生视频支持, 16:9(默认), 9:16。
        /// 
        /// 注：关于具体模型支持的宽高比例，可查看具体模型官网介绍获取更完整描述。
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
        }
    }
}

