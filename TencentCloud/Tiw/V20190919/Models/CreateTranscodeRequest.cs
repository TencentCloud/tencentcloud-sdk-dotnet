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

    public class CreateTranscodeRequest : AbstractModel
    {
        
        /// <summary>
        /// 客户的SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 需要进行转码文件地址
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 是否为静态PPT，默认为False；
        /// 如果IsStaticPPT为False，后缀名为.ppt或.pptx的文档会动态转码成HTML5页面，其他格式的文档会静态转码成图片；如果IsStaticPPT为True，所有格式的文档会静态转码成图片；
        /// </summary>
        [JsonProperty("IsStaticPPT")]
        public bool? IsStaticPPT{ get; set; }

        /// <summary>
        /// 转码后文档的最小分辨率，不传、传空字符串或分辨率格式错误则使用文档原分辨率
        /// 
        /// 注意分辨率宽高中间为英文字母"xyz"的"x"
        /// </summary>
        [JsonProperty("MinResolution")]
        public string MinResolution{ get; set; }

        /// <summary>
        /// 动态PPT转码可以为文件生成该分辨率的缩略图，不传、传空字符串或分辨率格式错误则不生成缩略图，分辨率格式同MinResolution
        /// 
        /// 静态转码这个参数不起作用
        /// </summary>
        [JsonProperty("ThumbnailResolution")]
        public string ThumbnailResolution{ get; set; }

        /// <summary>
        /// 转码文件压缩格式，不传、传空字符串或不是指定的格式则不生成压缩文件，目前支持如下压缩格式：
        /// 
        /// zip： 生成`.zip`压缩包
        /// tar.gz： 生成`.tar.gz`压缩包
        /// </summary>
        [JsonProperty("CompressFileType")]
        public string CompressFileType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "IsStaticPPT", this.IsStaticPPT);
            this.SetParamSimple(map, prefix + "MinResolution", this.MinResolution);
            this.SetParamSimple(map, prefix + "ThumbnailResolution", this.ThumbnailResolution);
            this.SetParamSimple(map, prefix + "CompressFileType", this.CompressFileType);
        }
    }
}

