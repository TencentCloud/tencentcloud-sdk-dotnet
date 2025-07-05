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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppletInfo : AbstractModel
    {
        
        /// <summary>
        /// 客户JS包
        /// </summary>
        [JsonProperty("AppletJsUrl")]
        public string AppletJsUrl{ get; set; }

        /// <summary>
        /// 小程序加固等级配置
        /// 1 - 开启代码混淆、代码压缩、代码反调试保护。 2 - 开启字符串编码和代码变换，代码膨胀，随机插入冗余代码，开启代码控制流平坦化，保证业务逻辑正常前提下，扁平化代码逻辑分支，破坏代码简单的线性结构。 3 - 开启代码加密，对字符串、函数、变量、属性、类、数组等结构进行加密保护，更多得代码控制流平坦化，扁平化逻辑分支。
        /// </summary>
        [JsonProperty("AppletLevel")]
        public long? AppletLevel{ get; set; }

        /// <summary>
        /// 本次加固输出产物名称，如”test.zip“,非空必须是 ”.zip“结尾
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppletJsUrl", this.AppletJsUrl);
            this.SetParamSimple(map, prefix + "AppletLevel", this.AppletLevel);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

