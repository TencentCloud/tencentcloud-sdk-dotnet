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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkillState : AbstractModel
    {
        
        /// <summary>
        /// SKILL安装状态
        /// 枚举值：
        /// 0：未安装
        /// 1：安装中
        /// 2：已安装
        /// 3：安装失败
        /// 4：卸载中
        /// 5：卸载失败
        /// </summary>
        [JsonProperty("SkillInstallStatus")]
        public long? SkillInstallStatus{ get; set; }

        /// <summary>
        /// SKILL安装/卸载操作时间
        /// 参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）
        /// </summary>
        [JsonProperty("SkillInstallTime")]
        public string SkillInstallTime{ get; set; }

        /// <summary>
        /// SKILL安装/卸载结果描述信息
        /// </summary>
        [JsonProperty("SkillInstallResult")]
        public string SkillInstallResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SkillInstallStatus", this.SkillInstallStatus);
            this.SetParamSimple(map, prefix + "SkillInstallTime", this.SkillInstallTime);
            this.SetParamSimple(map, prefix + "SkillInstallResult", this.SkillInstallResult);
        }
    }
}

