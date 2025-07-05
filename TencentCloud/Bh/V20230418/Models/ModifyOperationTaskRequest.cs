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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyOperationTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 任务类型, 1 - 手工执行, 2 - 周期性自动执行
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 执行账号
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// 超时时间,单位秒
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// 执行脚本内容
        /// </summary>
        [JsonProperty("Script")]
        public string Script{ get; set; }

        /// <summary>
        /// 执行主机集合，满足条件以下三个条件：1. 资产绑定可用的专业版或国密版堡垒机服务；2、资产类型为linux资产；3、用户具有资产权限，且资产添加了指定执行账号
        /// </summary>
        [JsonProperty("DeviceIdSet")]
        public ulong?[] DeviceIdSet{ get; set; }

        /// <summary>
        /// 执行间隔，单位天. 手工执行时无需传入
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 首次执行日期，默认1970-01-01T08:00:01+08:00,手工执行时无需传入
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// Script参数是否需要进行base64编码后传递，1-需要进行base64编码后传递，非1值-不需要进行base64编码后传递
        /// </summary>
        [JsonProperty("Encoding")]
        public ulong? Encoding{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "Script", this.Script);
            this.SetParamArraySimple(map, prefix + "DeviceIdSet.", this.DeviceIdSet);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "Encoding", this.Encoding);
        }
    }
}

