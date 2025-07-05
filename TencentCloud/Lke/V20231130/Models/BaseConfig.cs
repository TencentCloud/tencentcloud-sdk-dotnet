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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaseConfig : AbstractModel
    {
        
        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 应用头像url，在CreateApp和ModifyApp中作为入参必填。
        /// 作为入参传入说明：
        /// 1. 传入的url图片限制为jpeg和png，大小限制为500KB，url链接需允许head请求。
        /// 2. 如果用户没有对象存储，可使用“获取文件上传临时密钥”(DescribeStorageCredential)接口，获取cos临时密钥和上传路径，自行上传头像至cos中并获取访问链接。
        /// </summary>
        [JsonProperty("Avatar")]
        public string Avatar{ get; set; }

        /// <summary>
        /// 应用描述
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Avatar", this.Avatar);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
        }
    }
}

