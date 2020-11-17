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

namespace TencentCloud.Zj.V20190121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PushMmsContentRequest : AbstractModel
    {
        
        /// <summary>
        /// 商户证书
        /// </summary>
        [JsonProperty("License")]
        public string License{ get; set; }

        /// <summary>
        /// 素材样例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public long? InstanceId{ get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("Tel")]
        public string Tel{ get; set; }

        /// <summary>
        /// 附带数据字段
        /// </summary>
        [JsonProperty("Session")]
        public string Session{ get; set; }

        /// <summary>
        /// 动态参数key(即申请样例时设置的u_或p_开头的动态参数,要求序号有序)
        /// </summary>
        [JsonProperty("DynamicParaKey")]
        public string[] DynamicParaKey{ get; set; }

        /// <summary>
        /// 动态参数值,和DynamicParaKey对应
        /// </summary>
        [JsonProperty("DynamicParaValue")]
        public string[] DynamicParaValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "License", this.License);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Tel", this.Tel);
            this.SetParamSimple(map, prefix + "Session", this.Session);
            this.SetParamArraySimple(map, prefix + "DynamicParaKey.", this.DynamicParaKey);
            this.SetParamArraySimple(map, prefix + "DynamicParaValue.", this.DynamicParaValue);
        }
    }
}

