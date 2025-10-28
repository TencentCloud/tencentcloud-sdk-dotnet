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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAccountRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。可通过[DescribeDBInstances](https://cloud.tencent.com/document/api/409/16773)接口获取
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// 创建的账号名称。由字母（a-z, A-Z）、数字（0-9）、下划线（_）组成，以字母或（_）开头，最多63个字符。不能使用系统保留关键字，不能为postgres，且不能由pg_或tencentdb_开头
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 账号类型。当前支持normal、tencentDBSuper两个输入。normal指代普通用户，tencentDBSuper为拥有pg_tencentdb_superuser角色的账号。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 账号对应的密码。密码规则如下：
        /// <li>长度8 ~ 32位，推荐使用12位以上的密码</li>
        /// <li>不能以" / "开头</li>
        /// <li>必须包含以下四项:</li>
        /// 
        /// 小写字母 a ~ z           
        /// 大写字母 A ～ Z
        /// 数字 0 ～ 9
        /// 特殊字符 ()`~!@#$%^&*-+=_|{}[]:<>,.?/
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 账号备注。只允许英文字母、数字、下划线、中划线，以及全体汉字，限60个字符
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 账号是否开启CAM验证
        /// </summary>
        [JsonProperty("OpenCam")]
        public bool? OpenCam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "OpenCam", this.OpenCam);
        }
    }
}

