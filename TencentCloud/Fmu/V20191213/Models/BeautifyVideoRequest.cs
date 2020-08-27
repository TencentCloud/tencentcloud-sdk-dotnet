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

namespace TencentCloud.Fmu.V20191213.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BeautifyVideoRequest : AbstractModel
    {
        
        /// <summary>
        /// 视频url地址
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 美颜参数 - 美白、平滑、大眼和瘦脸。参数值范围[0, 100]。参数值为0，则不做美颜。参数默认值为0。目前默认取数组第一个元素是对所有人脸美颜。
        /// </summary>
        [JsonProperty("BeautyParam")]
        public BeautyParam[] BeautyParam{ get; set; }

        /// <summary>
        /// 目前只支持mp4
        /// </summary>
        [JsonProperty("OutputVideoType")]
        public string OutputVideoType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamArrayObj(map, prefix + "BeautyParam.", this.BeautyParam);
            this.SetParamSimple(map, prefix + "OutputVideoType", this.OutputVideoType);
        }
    }
}

