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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageToObjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片列表
        /// </summary>
        [JsonProperty("ImageInfoList")]
        public ImageInfo[] ImageInfoList{ get; set; }

        /// <summary>
        /// 图片处理参数
        /// </summary>
        [JsonProperty("HandleParam")]
        public HandleParam HandleParam{ get; set; }

        /// <summary>
        /// 图片类别
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 是否使用分类引擎
        /// </summary>
        [JsonProperty("IsUsedClassify")]
        public bool? IsUsedClassify{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ImageInfoList.", this.ImageInfoList);
            this.SetParamObj(map, prefix + "HandleParam.", this.HandleParam);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "IsUsedClassify", this.IsUsedClassify);
        }
    }
}

