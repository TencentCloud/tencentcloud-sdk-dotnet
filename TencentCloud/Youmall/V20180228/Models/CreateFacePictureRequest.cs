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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFacePictureRequest : AbstractModel
    {
        
        /// <summary>
        /// 集团ID
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// 人物类型（0表示普通顾客，1 白名单，2 表示黑名单，101表示集团白名单，102表示集团黑名单）
        /// </summary>
        [JsonProperty("PersonType")]
        public long? PersonType{ get; set; }

        /// <summary>
        /// 图片BASE编码
        /// </summary>
        [JsonProperty("Picture")]
        public string Picture{ get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [JsonProperty("PictureName")]
        public string PictureName{ get; set; }

        /// <summary>
        /// 店铺ID，如果不填表示操作集团身份库
        /// </summary>
        [JsonProperty("ShopId")]
        public long? ShopId{ get; set; }

        /// <summary>
        /// 是否强制更新：为ture时会为用户创建一个新的指定PersonType的身份;目前这个参数已废弃，可不传
        /// </summary>
        [JsonProperty("IsForceUpload")]
        public bool? IsForceUpload{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "PersonType", this.PersonType);
            this.SetParamSimple(map, prefix + "Picture", this.Picture);
            this.SetParamSimple(map, prefix + "PictureName", this.PictureName);
            this.SetParamSimple(map, prefix + "ShopId", this.ShopId);
            this.SetParamSimple(map, prefix + "IsForceUpload", this.IsForceUpload);
        }
    }
}

