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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OperationLog : AbstractModel
    {
        
        /// <summary>
        /// 操作证书动作。
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 操作时间。
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 主账号
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 子账号
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// 证书ID
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 每个操作类型都对应一个具体的操作描述。以下是对每个操作类型及其描述的文字说明：
        /// 1. apply - 表示申请一个免费的证书。
        /// 2. delete - 表示删除操作。
        /// 3. download - 表示下载操作。
        /// 4. upload - 表示上传操作。
        /// 5. revoke - 表示吊销证书。
        /// 6. cancelRevoke - 表示取消吊销操作。
        /// 7. updateAlias - 表示更新备注信息。
        /// 8. changeProject - 表示将证书分配到某个项目。
        /// 9. uploadConfirmLetter - 表示上传确认函。
        /// 10. cancel - 表示取消订单操作。
        /// 11. replace - 表示重颁发证书。
        /// 12. downloadConfirmLetter - 表示下载证书吊销确认函。
        /// 13. editRevokeLetter - 表示上传证书吊销确认函。
        /// 14. renewVIP - 表示续费付费证书。
        /// 15. applyVIP - 表示申请付费证书。
        /// 16. submitInfo - 表示提交资料。
        /// 17. downloadConfirmLetter - 表示下载确认函模版。
        /// 18. uploadFromYunAPI - 表示通过云 API 上传。
        /// 19. transferIn - 表示证书转入操作。
        /// 20. transferOut - 表示证书转出操作。
        /// 21. refund - 表示申请退款。
        /// 22. multiYearsRenew - 表示多年期自动续期。
        /// 23. modifyDownloadLimit - 表示修改下载限制开关。
        /// 24. issued - 表示证书签发。
        /// 25. domainValidationPassed - 表示域名验证完成。
        /// 26. Resubmit - 表示证书重新申请。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

