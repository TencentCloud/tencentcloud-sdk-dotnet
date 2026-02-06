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
        /// 指定所生成视频的宽高比。
        /// 
        /// 不同模型支持的宽高比:
        /// 1. GEM支持：1:1、3:2、2:3、3:4、4:3、4:5、5:4、9:16、16:9 和 21:9。
        /// 
        /// 注：具体模型的宽高比参数，可查看相应模型官网获取更完整描述。
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// 指定图片输出分辨率。
        /// 
        /// 支持该参数的模型：
        /// 支持选择: 720P, 1080P, 2K, 4K。
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
        }
    }
}

