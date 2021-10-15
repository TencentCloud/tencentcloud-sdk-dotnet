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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListDiagnoseReportRequest : AbstractModel
    {
        
        /// <summary>
        /// 用于搜索诊断URL的关键字，不填时返回用户所有的诊断任务。
        /// </summary>
        [JsonProperty("KeyWords")]
        public string KeyWords{ get; set; }

        /// <summary>
        /// 用于搜索诊断系统返回的诊断链接，形如：http://cdn.cloud.tencent.com/self_diagnose/xxxxx
        /// </summary>
        [JsonProperty("DiagnoseLink")]
        public string DiagnoseLink{ get; set; }

        /// <summary>
        /// 请求源带协议头，形如：https://console.cloud.tencent.com
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyWords", this.KeyWords);
            this.SetParamSimple(map, prefix + "DiagnoseLink", this.DiagnoseLink);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
        }
    }
}

